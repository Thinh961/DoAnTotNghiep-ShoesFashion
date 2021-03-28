import { Component, OnInit } from '@angular/core';
import { SharedService } from '../../_services/shared.service';

@Component({
  selector: 'app-nha-cung-cap',
  templateUrl: './nha-cung-cap.component.html',
})
export class NhaCungCapComponent implements OnInit {

  constructor(private service:SharedService) { }

  ngOnInit() {
  }

}
