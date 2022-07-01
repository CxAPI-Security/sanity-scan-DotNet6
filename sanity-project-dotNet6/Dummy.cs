using System;
using Microsoft.AspNetCore.Mvc;

namespace sanity_project_csharp
{
    public class Dummy
    {
        [FromRoute]
        public int Id { get; set; }

        [FromBody]
        public Name name { get; set; }

        public Dummy()
        {
        }
    }
}

