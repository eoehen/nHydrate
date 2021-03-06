using nHydrate.Generator.Common.ProjectItemGenerators;

namespace nHydrate.Generator.SQLInstaller.ProjectItemGenerators
{
    public abstract class BaseDbScriptGenerator : BaseProjectItemGenerator
    {
        public override string LocalNamespaceExtension => SqlDatabaseProjectGenerator.NamespaceExtension;
    }
}

