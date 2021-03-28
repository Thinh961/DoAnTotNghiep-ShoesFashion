import { Component, OnInit } from '@angular/core';
import { SharedService } from '../../_services/shared.service';

@Component({
  selector: 'app-tin-tuc',
  templateUrl: './tin-tuc.component.html',
})
export class TinTucComponent implements OnInit {

  constructor(private service:SharedService) { }

  ngOnInit() {
  }

}
