Dim request As HttpWebRequest = DirectCast("https://su.qq.com/")
Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
Dim responseStream As Stream = response.GetResponseStream()
Dim reader As New StreamReader(responseStream)
Dim sourceCode As String = reader.ReadToEnd()
Dim htmlDoc As HtmlDocument = New HtmlDocument()
htmlDoc.LoadHtml(sourceCode)
Dim nodes As HtmlNodeCollection = htmlDoc.DocumentNode.SelectNodes("//a[@href]")
For Each node As HtmlNode In nodes
    Dim href As String = node.Attributes("href").Value
Next
'reader.Open()
'responseStream.Open()
'response.Open()
