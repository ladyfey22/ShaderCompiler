using Microsoft.Xna.Framework.Content.Pipeline;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaderCompiler
{
    class MyContext : ContentProcessorContext
    {
        public override string BuildConfiguration { get { return ""; } }
        public override TargetPlatform TargetPlatform { get { return TargetPlatform.Windows; } }
        public override GraphicsProfile TargetProfile { get { return GraphicsProfile.HiDef; } }

        public override ContentBuildLogger Logger => throw new NotImplementedException();

        public override OpaqueDataDictionary Parameters => throw new NotImplementedException();

        public override string OutputFilename => throw new NotImplementedException();

        public override string OutputDirectory => throw new NotImplementedException();

        public override string IntermediateDirectory => throw new NotImplementedException();

        public override void AddDependency(string filename)
        {
            throw new NotImplementedException();
        }

        public override void AddOutputFile(string filename)
        {
            throw new NotImplementedException();
        }

        public override TOutput BuildAndLoadAsset<TInput, TOutput>(ExternalReference<TInput> sourceAsset, string processorName, OpaqueDataDictionary processorParameters, string importerName)
        {
            throw new NotImplementedException();
        }

        public override ExternalReference<TOutput> BuildAsset<TInput, TOutput>(ExternalReference<TInput> sourceAsset, string processorName, OpaqueDataDictionary processorParameters, string importerName, string assetName)
        {
            throw new NotImplementedException();
        }

        public override TOutput Convert<TInput, TOutput>(TInput input, string processorName, OpaqueDataDictionary processorParameters)
        {
            throw new NotImplementedException();
        }
        // ... other overrides ...
    }
}
