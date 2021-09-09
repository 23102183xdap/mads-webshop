import { Component, OnInit } from '@angular/core';
import { CartItem, Product } from '../model';
import { BasketService } from '../service/basket.service';

@Component({
  selector: 'app-kvug',
  templateUrl: './kvug.component.html',
  styleUrls: ['./kvug.component.css']
})
export class KvugComponent implements OnInit {

  products: Product[] = [];
  CartItems: CartItem[] = [];

  constructor(
    private basketService: BasketService
  ) { }
  
  ngOnInit(): void {
    this.basketService.getBasket().subscribe(CartItems => this.CartItems = CartItems)
    console.log("Checkout", this.CartItems);
  }
  editbasket(id: number, antal: number): void {
    this.basketService.editbasket(id, antal);
    this.basketService.getBasket().subscribe(CartItems => this.CartItems = CartItems)
  }
  deleteBasket(id: number): void {
    console.log("DeleteBasket", id);
    this.basketService.removefrombasket(id);
    this.basketService.getBasket().subscribe(CartItems => this.CartItems = CartItems)
  }
  addtoOrder(): void {
    if (this.CartItems.length != 0) {
      console.log("Add order")
      this.basketService.buyeverthing()
        .subscribe(a => console.log(a));
      this.basketService.getBasket().subscribe(CartItems => this.CartItems = CartItems)
    }
    else {
      alert("Kurven er tom");
      console.log("Kurven er tom")
    }

  }
}
