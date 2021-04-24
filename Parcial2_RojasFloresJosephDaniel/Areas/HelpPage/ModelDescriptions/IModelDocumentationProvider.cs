using System;
using System.Reflection;

namespace Parcial2_RojasFloresJosephDaniel.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}