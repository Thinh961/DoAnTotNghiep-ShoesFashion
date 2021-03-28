import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'detail-student',
  templateUrl: './detail-student.component.html',
  styleUrls: ['./detail-student.component.scss']
})
export class DetailStudentComponent implements OnInit {
 // Input
 @Input() DataStudentChild:any;

  constructor() { }

  ngOnInit() {
  }

}
