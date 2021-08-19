import { Kategori } from './../domain';
import { KategoriService } from './../kategori-service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-admin-kategori',
  templateUrl: './admin-kategori.component.html',
  styleUrls: ['./admin-kategori.component.css']
})
export class AdminKategoriComponent implements OnInit {
  kategori: Kategori ={id: 0, title: "", beskrivelse: ""}
  kategorier: Kategori[] = [];

  constructor(
    private kategoriService: KategoriService,
  ) { }

  ngOnInit(): void {
    this.getKategorier();
  }

  getKategorier(): void {
    this.kategoriService.getKategoris()
    .subscribe(kategorier => this.kategorier = kategorier);
  }

  save(): void {
    if (this.kategori.id == 0){
      this.kategoriService.addkategori(this.kategori)
      .subscribe(Kategori => {
        this.kategori = {id: 0, title: "", beskrivelse: ""}
        this.getKategorier();
      });
    }
    else{
      this.kategoriService.updateKategori(this.kategori)
      .subscribe((x=>{
        this.kategori = {id: 0, title: "", beskrivelse: ""}
        this.getKategorier();
      }))
    }
  }
  
  edit(kategori: Kategori): void {
    this.kategori = kategori;
  }

  delete(kategori: Kategori): void{
    if (confirm(`Er du sikker på du vil slette: ${kategori.title} `)) {
      
      this.kategoriService.deleteKategori(kategori.id)
      .subscribe(_ => this.getKategorier());
    }
  }

}
