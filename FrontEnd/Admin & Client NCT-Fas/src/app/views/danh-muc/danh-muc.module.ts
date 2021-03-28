import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HttpClientModule} from '@angular/common/http';
import { FormsModule, ReactiveFormsModule} from '@angular/forms';
import { SharedService } from '../../_services/shared.service'

import { DanhMucRoutingModule } from './danh-muc-routing.module';
import { DanhMucComponent } from './danh-muc.component';
import { ShowDanhmucComponent } from './show-danhmuc/show-danhmuc.component';
import { AddEditDanhmucComponent } from './add-edit-danhmuc/add-edit-danhmuc.component';

@NgModule({
  declarations: [DanhMucComponent, ShowDanhmucComponent, AddEditDanhmucComponent],
  imports: [
    CommonModule,
    DanhMucRoutingModule,
    HttpClientModule,FormsModule, ReactiveFormsModule
  ],
  providers: [SharedService]
})
export class DanhMucModule { }
