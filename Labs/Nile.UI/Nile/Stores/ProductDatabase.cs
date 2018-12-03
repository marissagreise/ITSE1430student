/*
 * Marissa Greise
 * ITSE 1430
 * 12/3/2018
 */
using System;
using System.Collections.Generic;

namespace Nile.Stores
{
    /// <summary>Base class for product database.</summary>
    public abstract class ProductDatabase : IProductDatabase
    {        
        /// <summary>Adds a product.</summary>
        /// <param name="product">The product to add.</param>
        /// <returns>The added product.</returns>
        public Product Add ( Product product )
        {
            //TODO: Check arguments
            if (product == null)
                throw new ArgumentNullException("null product");

            //TODO: Validate product
            ObjectValidator.Validate(product);

            //Emulate database by storing copy
            return AddCore(product);
        }

        /// <summary>Get a specific product.</summary>
        /// <returns>The product, if it exists.</returns>
        public Product Get ( int id )
        {
            //TODO: Check arguments
            if(id <  0 )
            {
                throw new Exception("Invalid Id");
            }
            try
            {
                return GetCore( id);
            }
            catch (Exception e)
            {
                throw new Exception("Get failed.", e);
            }
        }
        
        /// <summary>Gets all products.</summary>
        /// <returns>The products.</returns>
        public IEnumerable<Product> GetAll ()
        {
            return GetAllCore();
        }
        
        /// <summary>Removes the product.</summary>
        /// <param name="id">The product to remove.</param>
        public void Remove ( int id )
        {
            //TODO: Check arguments
           try
            {
                RemoveCore(id);
            }
            catch (Exception e)
            {
                throw new Exception("Remove failed", e);
            }  
        }
        
        /// <summary>Updates a product.</summary>
        /// <param name="product">The product to update.</param>
        /// <returns>The updated product.</returns>
        public Product Update ( Product product )
        {
            //TODO: Check arguments
            if (product.Name == null)
                throw new ArgumentNullException(nameof(product.Name));
            else if (product.Name == "")
                throw new ArgumentException("Name cannot be empty.", nameof(product.Name));
            else if (product.Id < 0)
                throw new ArgumentException("Id must be > 0.", nameof(product.Id));
            else if (product.Price < 0)
                throw new ArgumentException("Price must be > 0.", nameof(product.Price));

            //TODO: Validate product
            ObjectValidator.Validate(product);

            //Get existing product
            var existing = GetCore(product.Id);
            if (existing == null)
                throw new Exception("Product cannot be found.");

            return UpdateCore(existing, product);
        }

        #region Protected Members

        protected abstract Product GetCore( int id );

        protected abstract IEnumerable<Product> GetAllCore();

        protected abstract void RemoveCore( int id );

        protected abstract Product UpdateCore( Product existing, Product newItem );

        protected abstract Product AddCore( Product product );
        #endregion
        protected abstract Product FindByName( string name );

        public bool ExistingProduct(string name)
        {
            var exist = FindByName(name);
            if (exist == null)
                return false;
            else
                return true;
        }
    }
}
