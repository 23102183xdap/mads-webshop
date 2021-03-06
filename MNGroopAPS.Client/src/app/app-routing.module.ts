import { AdminKategoriComponent } from './admin-kategori/admin-kategori.component';
import { KvugComponent } from './kvug/kvug.component';
import { HomepageComponent } from './homepage/homepage.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BolcherComponent } from './bolcher/bolcher.component';
import { KategoriComponent } from './kategori/kategori.component';
import { LakridsBolcherComponent } from './lakrids-bolcher/lakrids-bolcher.component';
import { SureBolcherComponent } from './sure-bolcher/sure-bolcher.component';
import { BlandetBolcherComponent } from './blandet-bolcher/blandet-bolcher.component';
import { VingummierComponent } from './vingummier/vingummier.component';
import { ChokoladeComponent } from './chokolade/chokolade.component';
import { HChokoladeComponent } from './h-chokolade/h-chokolade.component';
import { MChokoladeComponent } from './m-chokolade/m-chokolade.component';
import { SVingummierComponent } from './s-vingummier/s-vingummier.component';

const routes: Routes = [

  {path: '' , redirectTo: '/homepage', pathMatch: 'full'},
  {path: 'homepage', component:HomepageComponent},

  {path: 'adminkategori', component:AdminKategoriComponent},

  // {path:'', redirectTo:'/karegori', pathMatch: 'full'},
  {path: 'kategori' , component:KategoriComponent},
  
  // {path:'', redirectTo:'/kvug', pathMatch:'full'},
  {path: 'kvug', component:KvugComponent},

  // {path: '' , redirectTo: '/bolcher', pathMatch: 'full'},
  {path: 'bolcher', component:BolcherComponent},
  
  {path: 'lakrids-bolcher', component:LakridsBolcherComponent},

  {path: 'sure-bolcher', component:SureBolcherComponent},

  {path: 'blandet-bolcher', component:BlandetBolcherComponent},

  {path: 'vingummier', component:VingummierComponent},

  {path: 'chokolade', component:ChokoladeComponent},

  {path: 'h-chokolade', component:HChokoladeComponent},

  {path: 'm-chokolade', component:MChokoladeComponent},

  {path: 's-vingummier', component:SVingummierComponent}
  

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
