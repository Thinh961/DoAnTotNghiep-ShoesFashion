import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProductsComponent } from './products.component';
import { ShowProdComponent } from './show-prod/show-prod.component';


const routes: Routes = [
  {path:'', component:ProductsComponent,
  //  children:[
  //   {path:'./show-prod', component:ShowProdComponent},

  //   ]
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ProductsRoutingModule { }
