using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace UserStore.Configuration
{
    public class UserElementCollection : ConfigurationElementCollection
    {
        public UserElementCollection()
        {
            //UserElement element = (UserElement)CreateNewElement();

            //// Add the element to the collection.
            //Add(element);
        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.AddRemoveClearMap; }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new UserElement();
        }

        protected override Object GetElementKey(ConfigurationElement element)
        {
            return ((UserElement)element).Name;
        }

        public new string AddElementName
        {
            get { return base.AddElementName; }
            set { base.AddElementName = value; }
        }

        public new string ClearElementName
        {
            get { return base.ClearElementName; }
            set { base.AddElementName = value; }
        }

        public new string RemoveElementName
        {
            get { return base.RemoveElementName; }
        }

        public new int Count
        {
            get { return base.Count; }
        }

        public UserElement this[int index]
        {
            get
            {
                return (UserElement)BaseGet(index);
            }
            set
            {
                if (BaseGet(index) != null)
                {
                    BaseRemoveAt(index);
                }
                BaseAdd(index, value);
            }
        }

        new public UserElement this[string Name]
        {
            get { return (UserElement)BaseGet(Name); }
        }

        public int IndexOf(UserElement user)
        {
            return BaseIndexOf(user);
        }

        public void Add(UserElement user)
        {
            BaseAdd(user);

            // Add custom code here.
        }

        protected override void BaseAdd(ConfigurationElement element)
        {
            BaseAdd(element, false);

            // Add custom code here.
        }

        public void Remove(UserElement user)
        {
            if (BaseIndexOf(user) >= 0)
                BaseRemove(user.Name);
        }

        public void RemoveAt(int index)
        {
            BaseRemoveAt(index);
        }

        public void Remove(string name)
        {
            this.BaseRemove(name);
        }

        public void Clear()
        {
            BaseClear();

            // Add custom code here.
        }
    }
}
