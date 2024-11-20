using System;
using System.Collections.Generic;
using RazorLight;

namespace codegenerator_razor
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Definisikan model
            var model = new YourModel
            {
                NamespaceName = "GeneratedNamespace",
                ClassName = "GeneratedClass",
                Properties = new List<PropertyModel>
            {
                new PropertyModel { Type = "int", Name = "Id" },
                new PropertyModel { Type = "string", Name = "Name" }
            }
            };

            var templatePath = "Template.cshtml";

            // Baca template cshtml dari file
            string template = System.IO.File.ReadAllText(templatePath);

            // Buat engine RazorLight
            var engine = new RazorLightEngineBuilder()
                .UseFileSystemProject(Directory.GetCurrentDirectory())
                .UseMemoryCachingProvider()
                .Build();

            // Render template dengan model
            string result = await engine.CompileRenderAsync(templatePath, model);

            // Tampilkan hasil atau simpan ke file
            Console.WriteLine(result);
            System.IO.File.WriteAllText("GeneratedClass.cs", result);
        }
    }
}
