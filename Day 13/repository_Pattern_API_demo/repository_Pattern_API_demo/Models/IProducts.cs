namespace repository_Pattern_API_demo.Models
{
    public interface IProducts
    {

        List<Products> GetProductsList();

        Products GetProductById(int id);

        string AddNewProduct(Products newProductObj);

        string updateproduct(Products changes);

        string deleteProduct(int pId);



    }
}
