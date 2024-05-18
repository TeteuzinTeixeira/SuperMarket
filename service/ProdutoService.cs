using SuperMarket.model.entity;

namespace SuperMarketAPI.service;

public class ProdutoService
{
    public bool ValidarProduto(Produto produto)
    {
        if (produto.Equals(null) || produto?.Name == null || produto.Name.Trim() == "")
            return false;
        
        if (produto?.Price == null || produto.Price <= 0)
            return false;
        
        if (produto?.Quantity == null || produto.Quantity <= 0)
            return false;

        return true;
    }
}