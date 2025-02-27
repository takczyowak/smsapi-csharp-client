﻿using System;
using System.Collections.Specialized;
using SMSApi.Api.Response;

namespace SMSApi.Api.Action
{
    [Obsolete("Use GetGroup")]
    public class PhonebookGroupGet : Base<Group>
    {
        private string name;

        protected override RequestMethod Method => RequestMethod.POST;

        public PhonebookGroupGet Name(string name)
        {
            this.name = name;
            return this;
        }

        protected override string Uri()
        {
            return "phonebook.do";
        }

        protected override NameValueCollection Values()
        {
            return new NameValueCollection
            {
                { "get_group", name }
            };
        }
    }
}
