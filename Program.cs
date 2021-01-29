using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Content.Pipeline.Graphics;
using Microsoft.Xna.Framework.Content.Pipeline.Processors;

namespace ShaderCompiler
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length != 2)
            {
                Console.WriteLine("Usage is:\n ShaderCompiler EffectFile.fx OutputFile.cso");
                return;
            }


            string fx = File.ReadAllText(args[0]);

            if(String.IsNullOrEmpty(fx))
            {
                Console.WriteLine("Failed to load the effect file" + fx);
                return;
            }

            EffectProcessor effectProcessor = new EffectProcessor();
            var effect = effectProcessor.Process(new EffectContent { EffectCode = fx }, new MyContext());

            byte[] yourEffectCode = effect.GetEffectCode();
            File.WriteAllBytes(args[1], yourEffectCode);
        }
    }
}
