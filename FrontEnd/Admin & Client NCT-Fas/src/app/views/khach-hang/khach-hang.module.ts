import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HttpClientModule} from '@angular/common/http';
import { FormsModule, ReactiveFormsModule} from '@angular/forms';
import { SharedService } from '../../_services/shared.service'

import { KhachHangRoutingModule } from './khach-hang-routing.module';
import { KhachHangComponent } from './khach-hang.component';
import { ShowKhComponent } from './show-kh/show-kh.component';
import { AddEditKhComponent } from './add-edit-kh/add-edit-kh.component';

@NgModule({
  declarations: [KhachHangComponent, ShowKhComponent, AddEditKhComponent],
  imports: [
    CommonModule,
    KhachHangRoutingModule,
    HttpClientModule, FormsModule, ReactiveFormsModule
  ],
  providers: [SharedService]
})
export class KhachHangModule { }
