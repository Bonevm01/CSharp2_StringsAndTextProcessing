//12. Write a program that parses an URL address given in the format:
//	and extracts from it the [protocol], [server] and [resource] elements. For example from the URL http://www.devbg.org/forum/index.php 
//  the following information should be extracted:
//	[protocol] = "http"
//	[server] = "www.devbg.org"
//	[resource] = "/forum/index.php"


using System;

class URLAddress
{
    static void Main()
    {
        string urlAddress = "http://www.devbg.org/forum/index.php";
        Console.WriteLine("The full URL address is : {0}", urlAddress);
        int index = urlAddress.IndexOf("//");
        string protocol = urlAddress.Substring(0, index - 1);
        Console.WriteLine("[protocol] = \"{0}\"", protocol);
        int index2 = urlAddress.IndexOf("/", index+2);
        string server = urlAddress.Substring(index+2, index2-index-2);
        Console.WriteLine("[server] = \"{0}\"", server);
        string resource = urlAddress.Substring(index2);
        Console.WriteLine("[resource] = \"{0}\"", resource);
    }
}
