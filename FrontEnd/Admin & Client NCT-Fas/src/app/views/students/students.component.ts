import { Component, OnInit,Input } from "@angular/core";
import { StudentsService } from "../../_services/students.service";
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from "@angular/forms";
import { from } from "rxjs";
@Component({
  selector: "app-students",
  templateUrl: "./students.component.html",
  styleUrls: ["./students.component.scss"],
})
export class StudentsComponent implements OnInit {
  constructor(
    private crudStudent: StudentsService,
    private FormBuilder: FormBuilder
  ) {}

  addcourse: FormGroup;
  page = 1;
  count = 0;
  tableSize = 5;
  tableSizes = [3, 6, 9, 12];

  Employee: any;
  DataEmployeeEdit = {
    id: "",
    username: "",
    email: "",
    password: "",
  };
  EmployeeListArray = [];



  ngOnInit(): void {
    this.getCourse();
    // Call function Form Validator
    this.ValidatorForm();

    //Call funciton skills
  }

  getCourse() {

    this.crudStudent.getCourse().subscribe((data) => {
      this.Employee = data;
      this.Employee.forEach((element) => {
        this.EmployeeListArray.push(element);
      });
    });
  }

  // Funciton Get skill

  // function UpdateEmployee:
  CreateCourse(val) {
    this.crudStudent.createCourse(val).subscribe(
      (data) => {
        this.EmployeeListArray.push(val);
        this.Alert_successFunction();
      },
      (error) => {
        this.Alert_dangerFunction();
      }
    );
  }

  // Function Edit Employee
  UpdateCourse(val) {
    this.crudStudent.EditCourse(val).subscribe(
      (data) => {
        this.Alert_successFunction();
        this.findIndexEdit(val);
      },
      (error) => {
        this.Alert_dangerFunction();
      }
    );
  }

  findIndexEdit(val) {
    let i = -1;
    this.EmployeeListArray.forEach((element) => {
      i++;
      if (element.id == val.id) {
        this.EmployeeListArray.splice(i, 1, val);
        return i;
      }
    });
  }
  // End Edit function

  // function CreateEmployee:
  DeleteCourse(id) {
    if (confirm("ban co chac chan khong")) {
      this.crudStudent.DeleteCourse(id).subscribe(
        (data) => {
          this.Alert_successFunction();
        },
        (error) => {
          this.Alert_dangerFunction();
        }
      );
      this.findIndexDelete(id);
    }
  }

  findIndexDelete(id) {
    let i = -1;
    this.EmployeeListArray.forEach((element) => {
      i++;
      if (element.id == id) {
        this.EmployeeListArray.splice(i, 1);
        return i;
      }
    });
  }

  // Check isAddEm false ? true
  isAddEm: boolean;
  GetDataCheckisAddorEdit(bl, val) {
    if (bl) {
      this.formValidator.controls.id.patchValue(val.id);
      this.formValidator.controls.username.patchValue(val.username);
      this.formValidator.controls.email.patchValue(val.email);
      this.formValidator.controls.password.patchValue(val.password);

      return (this.isAddEm = false);
    } else {
      return (this.isAddEm = true);
    }
  }

  // Function Validator Form
  formValidator: FormGroup;
  ValidatorForm() {
    this.formValidator = this.FormBuilder.group({
      id: [""],
      username: ["", [Validators.required]],
      email: ["", [Validators.required]],
      password: ["", [Validators.required]],
    });
  }

  // Alert variable
  alert_success = false;
  alert_danger = false;
  // Function show alert

  AlertFunction(success: boolean) {
    // let submitButton = document.querySelector("#submitButton");
    // submitButton.setAttribute("disabled", "true");
    // setTimeout(() => {
    //   submitButton.removeAttribute("disabled");
    // }, 2000);
    if (success) {
      setTimeout(() => {
        this.alert_success = !this.alert_success;
      }, 1000);
    } else {
      setTimeout(() => {
        this.alert_danger = !this.alert_danger;
      }, 2000);
    }
  }
  Alert_successFunction() {
    this.alert_success = true;
    // call function set alert_success = true
    this.AlertFunction(true);
  }
  Alert_dangerFunction() {
    this.alert_danger = true;

    // call function set alert_danger = true
    this.AlertFunction(false);
  }

  // END Function show alert

  fetchPosts(): void {
    this.crudStudent.getCourse().subscribe(
      (response) => {
        this.Employee = response;
      },
      (error) => {
        console.log(error);
      }
    );
  }

  onTableDataChange(event) {
    this.page = event;
    this.fetchPosts();
  }

  onTableSizeChange(event): void {
    this.tableSize = event.target.value;
    this.page = 1;
    this.fetchPosts();
  }

   // Search students by Id:
   getEmployeeById(id) {
     console.log(id);

    let i = -1;
    let item;
    this.EmployeeListArray.forEach(element => {
      i++;

      if (this.EmployeeListArray[i].id == id) { // tim ra student tai by id
        item = this.EmployeeListArray[i];
        this.EmployeeListArray[i] = this.EmployeeListArray[0];
        this.EmployeeListArray[0] = item;
      }
    });
  }
    // Function select data in Parrent Component to Chirld Component
    DataStudentParrent: any;
    DataEmployeeParrentFunction(val) {
      console.log(val);

      this.DataStudentParrent = val;
    }
}
