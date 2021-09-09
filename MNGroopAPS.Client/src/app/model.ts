export interface Product {
    id: number,
    title: string,
    storage: number,
    categoryId: number,
    category: Category,
    price: number,
    images: string
}

export interface Category{
    id: number;
    title: string;
}

export interface User{
    id?: number,
    email: string,
    password: string,
    roleId?: number,
    customer: Array<Customer>
}
export interface Customer{
    firstname: string,
    lastname: String,
    street: string,
    zipcode: string,
    city: string
}

export interface CartItem {
    productid: number,
    navn: string,
    pris: number,
    antal: number,
    storage: number,
    id: number,
    orderId: number
}
export interface Order {
    date : Date,
    id : number,
    orderDetails: Array<OrderDetails>
}
export interface OrderDetails {
    amount: number
    id: number
    orderId: number
    price: number
    productsId: number
}

export interface Product{
    id: number,
    title: string,
    storage: number,
    categoryId: number,
    category: Category,
    price: number,
    images: string
}

export interface Category{
    id: number;
    title: string;
}