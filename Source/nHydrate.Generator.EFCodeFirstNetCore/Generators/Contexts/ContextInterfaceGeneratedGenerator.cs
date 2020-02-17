using nHydrate.Generator.Common.EventArgs;
using nHydrate.Generator.Common.GeneratorFramework;

namespace nHydrate.Generator.EFCodeFirstNetCore.Generators.Contexts
{
    [GeneratorItem("ContextInterfaceGeneratedGenerator", typeof(ContextInterfaceExtenderGenerator))]
    public class ContextInterfaceGeneratedGenerator : EFCodeFirstNetCoreProjectItemGenerator
    {
        #region Class Members

        private const string RELATIVE_OUTPUT_LOCATION = @"\";

        #endregion

        #region Overrides

        public override int FileCount => 1;

        public override void Generate()
        {
            var template = new ContextInterfaceGeneratedTemplate(_model);
            var fullParentName = RELATIVE_OUTPUT_LOCATION + template.ParentItemName;
            var eventArgs = new ProjectItemGeneratedEventArgs(template.FileName, template.FileContent, ProjectName, fullParentName, this, true);
            OnProjectItemGenerated(this, eventArgs);
            var gcEventArgs = new ProjectItemGenerationCompleteEventArgs(this);
            OnGenerationComplete(this, gcEventArgs);
        }

        public override string LocalNamespaceExtension
        {
            get { return EFCodeFirstNetCoreProjectGenerator.NamespaceExtension; }
        }

        #endregion

    }
}
