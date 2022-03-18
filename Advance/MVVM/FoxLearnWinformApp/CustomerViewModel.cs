using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoxLearnWinformApp
{
    public class CustomerViewModel : IDisposable
    {
        private NorthwindEntities db;
        public CustomerViewModel() => db = new NorthwindEntities();

        public BindingSource CustomerBindingSource { get; set; }

        public void Load()
        {
            db.Customers.Load();
            CustomerBindingSource.DataSource = db.Customers.Local.ToBindingList();
        }

        public void Delete() => CustomerBindingSource.RemoveCurrent();
        public void New() => CustomerBindingSource.AddNew();
        public void Save()
        {
            CustomerBindingSource.EndEdit();
            db.SaveChanges();

            //try
            //{
            //    db.SaveChanges();
            //}
            //catch (DbEntityValidationException ex)
            //{
            //    foreach (var entityValidationErrors in ex.EntityValidationErrors)
            //    {
            //        foreach (var validationError in entityValidationErrors.ValidationErrors)
            //        {
            //            System.Diagnostics.Debug.WriteLine("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
            //        }
            //    }
            //}
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
