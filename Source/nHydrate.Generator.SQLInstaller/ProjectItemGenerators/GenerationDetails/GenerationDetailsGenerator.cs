using nHydrate.Generator.Common.EventArgs;
using nHydrate.Generator.Common.GeneratorFramework;

namespace nHydrate.Generator.SQLInstaller.ProjectItemGenerators.GenerationDetails
{
    [GeneratorItem("GenerationDetails", typeof(SqlDatabaseProjectGenerator))]
    public class GenerationDetailsGenerator : BaseDbScriptGenerator
    {
        #region Class Members

        private const string PARENT_ITEM_NAME = @"";

        #endregion

        #region Overrides

        public override int FileCount => 1;

        public override void Generate()
        {
            var template = new GenerationDetailsTemplate(_model);
            var fullFileName = template.FileName;
            var eventArgs = new ProjectItemGeneratedEventArgs(fullFileName, template.FileContent, ProjectName, PARENT_ITEM_NAME, ProjectItemType.Folder, this, true);
            eventArgs.Properties.Add("BuildAction", 3);
            OnProjectItemGenerated(this, eventArgs);
            var gcEventArgs = new ProjectItemGenerationCompleteEventArgs(this);
            OnGenerationComplete(this, gcEventArgs);
        }

        #endregion

    }
}
