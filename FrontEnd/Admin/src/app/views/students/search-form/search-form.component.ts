import { Component, OnInit, Output, EventEmitter,Input } from "@angular/core";
import { CrudEmployeeService } from "../../../_services/CrudEmployee.Service";
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from "@angular/forms";

@Component({
  selector: "search-form",
  templateUrl: "./search-form.component.html",
  styleUrls: ["./search-form.component.scss"],
})
export class SearchFormComponent implements OnInit {
 
  @Output() DataOut = new EventEmitter<number>();
  onSearch(id) {
    this.DataOut.emit(id);
  }
  //

  //
  Employee = {
    id: "",
    username: "",
    email: "",
    password: "",
  };

  ActiveEmployee = {
    title: "",
    isAdd: true,
  };

  formValidator: FormGroup;

  // Alert variable
  alert_success = false;
  alert_danger = false;
  constructor(
    private CrudEmployee: CrudEmployeeService,
    private formBuilder: FormBuilder
  ) {}

  ngOnInit(): void {}
}
