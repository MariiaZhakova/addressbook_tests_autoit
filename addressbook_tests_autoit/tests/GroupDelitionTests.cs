using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupDelitionTests : TestBase
    {
        [Test]
        public void TestGroupDelition()
        {
            List<GroupData> oldGroups = app.Groups.GetGroupList();

            if (oldGroups.Count == 0)
            {
                app.Groups.Add(new GroupData() { Name = "test" });
                oldGroups = app.Groups.GetGroupList();
            }

            app.Groups.Delete(0);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(0);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
