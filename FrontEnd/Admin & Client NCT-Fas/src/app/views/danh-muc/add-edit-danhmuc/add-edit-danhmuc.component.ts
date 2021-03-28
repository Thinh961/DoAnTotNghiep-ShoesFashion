import { Component, OnInit, Input } from '@angular/core';
import { SharedService } from "../../../_services/shared.service"
import { ShowDanhmucComponent } from '../show-danhmuc/show-danhmuc.component';

@Component({
  selector: 'app-add-edit-danhmuc',
  templateUrl: './add-edit-danhmuc.component.html',
  styleUrls: ['./add-edit-danhmuc.component.scss']
})
export class AddEditDanhmucComponent implements OnInit {

  constructor(
    private service:SharedService,
    private showCate:ShowDanhmucComponent,
  ) { }

  @Input() category:any;
    id:string;
    categoryName:string;
    description:string;

  ngOnInit() {
    this.id = this.category.id;
    this.categoryName = this.category.categoryName;
    this.description = this.category.description;
    this.showCate.refreshCateList();

  }

  Close(){
    this.showCate.refreshCateList();
  }

  add(){
    var val = {
      id:this.id,
      categoryName:this.categoryName,
      description:this.description,
    };
    this.service.addCate(val).subscribe(res =>{
      // alert(res.toString());
      // console.log(res)
      alert("Thêm thành công!");
      this.showCate.refreshCateList();
    });
  }


  update(){
    var val = {
      id:this.id,
      categoryName:this.categoryName,
      description:this.description,
    };
    // console.log(val)
    this.service.updateCate(val).subscribe(res =>{
      // alert(res.toString());
      alert("Đã cập nhật!");
      // this.showProd.closeClick();
      this.showCate.refreshCateList();
    });
  }

}
