import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HttpClientModule} from '@angular/common/http';
import { FormsModule, ReactiveFormsModule} from '@angular/forms';
import { SharedService } from '../../_services/shared.service'

import { DonDatHangRoutingModule } from './don-dat-hang-routing.module';
import { ShowDdhComponent } from './show-ddh/show-ddh.component';
import { AddEditDdhComponent } from './add-edit-ddh/add-edit-ddh.component';
import { DonDatHangComponent } from './don-dat-hang.component';

@NgModule({
  declarations: [ShowDdhComponent, AddEditDdhComponent, DonDatHangComponent],
  imports: [
    CommonModule,
    DonDatHangRoutingModule,
    HttpClientModule, FormsModule, ReactiveFormsModule
  ],
  providers: [SharedService]
})
export class DonDatHangModule { }
