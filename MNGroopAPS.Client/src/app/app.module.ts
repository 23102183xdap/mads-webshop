import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { BolcherComponent } from './bolcher/bolcher.component';
import { HomepageComponent } from './homepage/homepage.component';
import { KategoriComponent } from './kategori/kategori.component';
import { KvugComponent } from './kvug/kvug.component';
import { KategoriDeatailsComponent } from './kategori-deatails/kategori-deatails.component';
import { AdminKategoriComponent } from './admin-kategori/admin-kategori.component';



@NgModule({
  declarations: [
    AppComponent,
    BolcherComponent,

    HomepageComponent,
    KategoriComponent,
    KvugComponent,
    KategoriDeatailsComponent,
    AdminKategoriComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
