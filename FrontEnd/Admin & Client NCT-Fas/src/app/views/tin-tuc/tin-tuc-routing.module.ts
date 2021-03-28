import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TinTucComponent } from './tin-tuc.component';

const routes: Routes = [{ path:'',  component:TinTucComponent}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TinTucRoutingModule { }
