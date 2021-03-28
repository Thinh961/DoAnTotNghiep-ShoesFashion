import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DonDatHangComponent } from './don-dat-hang.component';

const routes: Routes = [
  {path:'', component:DonDatHangComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class DonDatHangRoutingModule { }
