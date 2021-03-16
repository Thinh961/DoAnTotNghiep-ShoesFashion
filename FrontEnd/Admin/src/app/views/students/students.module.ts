import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";

import { StudentsRoutingModule } from "./students-routing.module";
import { StudentsComponent } from "./students.component";
import { SearchFormComponent } from "./search-form/search-form.component";
import { from } from "rxjs";
// pagination
import { NgxPaginationModule } from "ngx-pagination";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { DetailStudentComponent } from './detail-student/detail-student.component';
@NgModule({
  declarations: [StudentsComponent,SearchFormComponent, DetailStudentComponent],
  imports: [
    CommonModule,
    StudentsRoutingModule,
    NgxPaginationModule,
    FormsModule,
    ReactiveFormsModule,
  ],
})
export class StudentsModule {}
