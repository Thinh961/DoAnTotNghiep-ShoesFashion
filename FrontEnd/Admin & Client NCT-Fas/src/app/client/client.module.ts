import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ClientRoutingModule } from './client-routing.module';
import { HomeComponent } from './pages/home/home.component';
import { AboutComponent } from './pages/about/about.component';
import { ContactComponent } from './pages/contact/contact.component';
import { ProductsComponent } from './pages/products/products.component';
import { ProductDetailComponent } from './pages/product-detail/product-detail.component';
import { ShopComponent } from './pages/shop/shop.component';

@NgModule({
  declarations: [HomeComponent, AboutComponent, ContactComponent, ProductsComponent, ProductDetailComponent, ShopComponent,],
  imports: [
    CommonModule,
    ClientRoutingModule
  ]
})
export class ClientModule { }
