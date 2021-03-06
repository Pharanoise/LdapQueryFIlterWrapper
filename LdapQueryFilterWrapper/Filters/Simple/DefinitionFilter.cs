﻿namespace LdapQueryFilterWrapper.Filters.Simple
{
    public class DefinitionFilter : Filter
    {
        private string attributeName;

        public DefinitionFilter(string attributeName)
        {
            this.attributeName = LdapInputSanitizer.Sanitize(attributeName);
        }

        public override string ToString()
        {
            return string.Format("({0}=*)", attributeName);
        }
    }
}
