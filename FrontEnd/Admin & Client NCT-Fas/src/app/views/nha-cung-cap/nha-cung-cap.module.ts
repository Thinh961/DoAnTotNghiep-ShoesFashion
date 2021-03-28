import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HttpClientModule} from '@angular/common/http';
import { FormsModule, ReactiveFormsModule} from '@angular/forms';
import { SharedService } from '../../_services/shared.service'

import { NhaCungCapRoutingModule } from './nha-cung-cap-routing.module';
import { NhaCungCapComponent } from './nha-cung-cap.component';
import { ShowNccComponent } from './show-ncc/show-ncc.component';
import { AddEditNccComponent } from './add-edit-ncc/add-edit-ncc.component';

@NgModule({
  declarations: [NhaCungCapComponent, ShowNccComponent, AddEditNccComponent],
  imports: [
    CommonModule,
    NhaCungCapRoutingModule,
    HttpClientModule,
    FormsModule, ReactiveFormsModule
  ],
  providers: [SharedService]
})
export class NhaCungCapModule { }
