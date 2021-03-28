import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule} from '@angular/common/http';
import { FormsModule, ReactiveFormsModule} from '@angular/forms';
import { SharedService } from '../../_services/shared.service'

import { TinTucRoutingModule } from './tin-tuc-routing.module';
import { TinTucComponent } from './tin-tuc.component';
import { ShowTintucComponent } from './show-tintuc/show-tintuc.component';
import { AddEditTintucComponent } from './add-edit-tintuc/add-edit-tintuc.component';

@NgModule({
  declarations: [TinTucComponent, ShowTintucComponent, AddEditTintucComponent],
  imports: [
    CommonModule,
    TinTucRoutingModule,
    HttpClientModule,
    FormsModule, ReactiveFormsModule
  ],
  providers: [SharedService]
})
export class TinTucModule { }
