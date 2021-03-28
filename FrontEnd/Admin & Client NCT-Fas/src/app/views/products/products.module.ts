import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ProductsRoutingModule } from './products-routing.module';
import { ProductsComponent } from './products.component';
import { ShowProdComponent } from './show-prod/show-prod.component';
import { AddEditProdComponent } from './add-edit-prod/add-edit-prod.component';
import { SharedService } from '../../_services/shared.service'

import { HttpClientModule} from '@angular/common/http';
import { FormsModule, ReactiveFormsModule} from '@angular/forms';


@NgModule({
  declarations: [ProductsComponent, ShowProdComponent, AddEditProdComponent],
  imports: [
    CommonModule,
    ProductsRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [SharedService]
})
export class ProductsModule { }
