using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ApiTest
{
    public class TodoListApiTests
    {
        [Test]
        public void GetTodoItemApiTest()
        {
            TodoApiClient todoApiClient = new TodoApiClient();
            var todoResponse = todoApiClient.GetTodoItemById(1);
        }

        [Test]
        public void GetTodoItemsApiTest()
        {
            TodoApiClient todoApiClient = new TodoApiClient();
            var todoItems = todoApiClient.GetTodoItems();
        }
    }
}
