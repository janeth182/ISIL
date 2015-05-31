using System;

namespace ProductMaintenance
{
	public class Category
	{
        int _categoryId;
        string _name;
        string _description;

	    public int CategoryId
	    {
	        get { return _categoryId; }
	    }

	    public string Name
	    {
	        get { return _name; }
	    }

	    public string Description
	    {
	        get { return _description; }
	    }

	    public Category(int categoryId, string name, string description)
		{
            _categoryId = categoryId;
            _name = name;
            _description = description;
		}

        public override string ToString()
        {
            return _name;
        }

	}
}
