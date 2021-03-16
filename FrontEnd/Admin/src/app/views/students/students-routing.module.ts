import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { DetailStudentComponent } from "./detail-student/detail-student.component";
import { StudentsComponent } from "./students.component";

const routes: Routes = [
  {
    path: "",
    component: StudentsComponent,
  },
  {
    path: "detail",
    component: DetailStudentComponent,
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class StudentsRoutingModule {}
