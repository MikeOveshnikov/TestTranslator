using System.Net.Http.Json;

namespace Test
{
	public class Model
	{
		public string Html { get; set; }

	}
	public class Program
	{
		private static readonly HttpClient _httpClient = new HttpClient();
		static async Task Main(string[] args)
		{

			var model = new Model { Html = "<h3>Identify the Available Resources Online</h3>\r\n\r\n<p>With the continuous growth of technology, the internet has become a vast resource for information and knowledge. The online world provides convenient access to a wide range of resources from various sources. Here are some of the available resources online:</p>\r\n\r\n<ol>\r\n  <li>\r\n    <h3>Open Educational Resources</h3>\r\n    <p>Open Educational Resources (OERs) are free materials that can be used for teaching, learning, and research. These resources include textbooks, lecture notes, videos, and quizzes that are available online for anyone to use.</p>\r\n  </li>\r\n  \r\n  <li>\r\n    <h3>Blogs and Websites</h3>\r\n    <p>Blogs and websites that focus on specific topics, such as science, technology, and current affairs, are invaluable resources for knowledge seekers. These sites offer articles and essays that cover different angles of a topic, providing diverse perspectives for research.</p>\r\n  </li>\r\n  \r\n  <li>\r\n    <h3>Podcasts</h3>\r\n    <p>Podcasts are audio programs that can be accessed through various streaming services. They cover many topics, from news and current events to entertainment and lifestyle. Podcasts provide an alternative way of learning for auditory learners.</p>\r\n  </li>\r\n</ol>\r\n\r\n<p>These resources are just a few examples of the vast array of information available online. Take the time to research and explore what the internet can offer – the possibilities are endless.</p>" };
			JsonContent content = JsonContent.Create(model);
			var response = await _httpClient.PostAsync("http://45.146.165.250/api/Translate/gettext", content); //5125 Translator/
			//var response = await _httpClient.PostAsync("http://localhost:5125/api/Translate/gettext", content);
			var result = await response.Content.ReadAsStringAsync();
			Console.WriteLine(result);
		}
	}
}