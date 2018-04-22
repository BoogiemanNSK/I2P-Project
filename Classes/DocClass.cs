﻿using I2P_Project.DataBase;

namespace I2P_Project.Classes
{
    // Class for easier testing process
    class DocClass
    {
        /// <summary> Row from Users table, for access in constant time </summary>
        private Document _current;

        public DocClass(string title)
        {
            _current = SDM.LMS.GetDocByTitle(title) ??
                new Document() { Id = -1, Title = "", Price = 0, Quantity = 0, IsRequested = false, Queue = "", DocType = -1 };
        }
        /// <summary> Getters from DB </summary>
        public int ID { get { return _current.Id; } }
        public string Title { get { return _current.Title; } }
        public string Autors { get { return _current.Autors; } }
        public int Price { get { return _current.Price; } }
        public int DocType { get { return _current.DocType; } }
        public int Quantity { get { return _current.Quantity; } }

		
    }

	public enum DocType
	{
		Book,
		Journal,
		AV
	}
}
