import java.io.BufferedOutputStream;
import java.io.FileOutputStream;
import java.io.IOException;
import java.nio.charset.StandardCharsets;

public class AdvancedFileWriter {
    public static void main(String[] args) {
        final String FILE_PATH = "output.bin";
        final int BUFFER_SIZE = 16 * 1024;  // 16KB buffer
        
        try (
            FileOutputStream fos = new FileOutputStream(FILE_PATH);
            BufferedOutputStream bos = new BufferedOutputStream(fos, BUFFER_SIZE)
        ) {
            // 1. Writing text data with explicit encoding
            String header = "FILE HEADER:\n";
            bos.write(header.getBytes(StandardCharsets.UTF_8));
            
            // 2. Writing raw binary data (PNG file signature example)
            byte[] pngSignature = {(byte) 0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A};
            bos.write(pngSignature);
            
            // 3. Writing large amounts of data efficiently
            StringBuilder largeData = new StringBuilder();
            for (int i = 0; i < 10000; i++) {
                largeData.append("Line ").append(i).append("\n");
            }
            bos.write(largeData.toString().getBytes(StandardCharsets.UTF_8));
            
            // 4. Manual flush for critical points
            bos.flush();
            System.err.println("Critical data flushed to disk");
            
            // 5. Appending final data
            bos.write("\nEND OF FILE".getBytes(StandardCharsets.UTF_8));
            
        } catch (IOException e) {
            System.err.println("I/O Error occurred: " + e.getClass().getSimpleName());
            System.err.println("Error details: " + e.getMessage());
            e.printStackTrace(System.err);
        }
    }
}