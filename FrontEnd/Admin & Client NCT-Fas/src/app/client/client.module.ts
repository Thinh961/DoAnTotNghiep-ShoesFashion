import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ClientRoutingModule } from './client-routing.module';
import { HomeComponent } from './pages/home/home.component';
import { AboutComponent } from './pages/about/about.component';
import { ContactComponent } from './pages/contact/contact.component';
import { ProductsComponent } from './pages/products/products.component';
import { ProductDetailComponent } from './pages/product-detail/product-detail.component';

@NgModule({
  declarations: [HomeComponent, AboutComponent, ContactComponent, ProductsComponent, ProductDetailComponent,],
  imports: [
    CommonModule,
    ClientRoutingModule
  ],
  exports: [HomeComponent, AboutComponent, ContactComponent, ProductsComponent, ProductDetailComponent]
})
export class ClientModule { }
