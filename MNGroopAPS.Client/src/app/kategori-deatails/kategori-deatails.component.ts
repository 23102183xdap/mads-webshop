import { KategoriService } from './../kategori-service';
import { Kategori } from './../domain';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-kategori-deatails',
  templateUrl: './kategori-deatails.component.html',
  styleUrls: ['./kategori-deatails.component.css']
})
export class KategoriDeatailsComponent implements OnInit {
    id: number = 0;
    kategori: Kategori = { title: "", beskrivelse: "", id: 0 };
  route: any;
  location: any;
  
  constructor() { }

  ngOnInit(): void {
    // this.id = (this.route.snapshot.paramMap.get('id') || 0) as number;
    // if (this.id == null || this.id == 0) {
    //   this.location.go('/kategori');
    // } else {
    //   this.getKategori();
    // }
  }
  // getKategori() {
  //   this.KategoriService.getKategori(this.id).subscribe(
  //     Kategori => Kategori != null ? this.Kategori = Kategori : this.location.go('/kategori'))
  //   )
  // }

  // save(): void {
  //   this.KategoriService.updateAuthor(this.id, this.Kategori)
  //     .subscribe(Kategori => {
  //       this.Kategori = Kategori
  //       this.message = "dit slik er gmet";

  //       setTimeout(() => {
  //         this.message = "";
  //       }, 3000);

  //     });
  // }

}
