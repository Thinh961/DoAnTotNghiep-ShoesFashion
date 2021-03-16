import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";

import { CourseRoutingModule } from "./course-routing.module";
import { CourseComponent } from "./course.component";

// pagination
import { NgxPaginationModule } from "ngx-pagination";
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { HttpClientModule, HttpClient } from "@angular/common/http";
@NgModule({
  declarations: [CourseComponent],
  imports: [
    CommonModule,
    CourseRoutingModule,
    NgxPaginationModule,
    FormsModule,
    ReactiveFormsModule,

  ],
})
export class CourseModule {}
