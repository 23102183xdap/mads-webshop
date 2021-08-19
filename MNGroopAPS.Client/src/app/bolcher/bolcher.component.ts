import { KategoriService } from './../kategori-service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-bolcher',
  templateUrl: './bolcher.component.html',
  styleUrls: ['./bolcher.component.css']
})
export class BolcherComponent implements OnInit {

  bolchername: string = "sur charry";
  Bolcher1: string[] = [];
  

  constructor() {
    //private KategoriService:KategoriService
  }

  ngOnInit(): void {
    
  }

}
