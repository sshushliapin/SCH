﻿using System.Collections.Generic;

namespace Sitecore.Hypermedia.Model
{
    public class WorkflowModel
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public ICollection<WorkflowStateModel> States { get; set; }
    }
}