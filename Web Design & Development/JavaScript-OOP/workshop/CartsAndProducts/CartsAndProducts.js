function solve() {
    function getProduct(productType, name, price) {
        
    }

    function getShoppingCart() {
    }

    return {
        getProduct: getProduct,
        getShoppingCart: getShoppingCart
    };
}

module.exports = solve();

const { getProduct, getShoppingCart } = solve();

let cart = getShoppingCart();

let pr1 = getProduct("Sweets", "Shokolad Milka", 2);
console.log(pr1);