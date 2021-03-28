import { Component, OnInit, Input } from '@angular/core';
import { SharedService } from "../../../_services/shared.service"
import { ShowTintucComponent } from '../show-tintuc/show-tintuc.component';

@Component({
  selector: 'app-add-edit-tintuc',
  templateUrl: './add-edit-tintuc.component.html',
})
export class AddEditTintucComponent implements OnInit {

  // SupplierList:any=[];
  // CategoryList:any=[];
  AdminList:any=[];

  constructor(
    private service:SharedService,
    private showTT:ShowTintucComponent
  ) { }

  @Input() news:any;
    id:string;
    shortContent:string;
    mainContent:string;
    title:string;
    image:string;
    adminId:string;

  ngOnInit() {
    this.showTT.refreshNewsList();
    this.refreshSuppList();
    this.id = this.news.id;
    this.shortContent = this.news.shortContent;
    this.mainContent = this.news.mainContent;
    this.title = this.news.title;
    this.image = this.news.image;
    this.adminId = this.adminId;
  }

  // refresh dữ liệu trả về từ Supplier(SuppList)
  refreshSuppList(){
    this.service.getAdmList().subscribe(data =>{
      // console.log(data);
     this.AdminList = data;
    });
  }

  // refresh dữ liệu trả về từ Category(CategoryList)
  // refreshCategoList(){
  //   this.service.getCateList().subscribe(data =>{
  //    this.CategoryList = data;
  //   });
  // }

  Close(){
    this.showTT.refreshNewsList();
  }

  add(){
    var val = {
      id:this.id,
      shortContent:this.shortContent,
      mainContent:this.mainContent,
      title:this.title,
      image:this.image,
      adminId:this.adminId,
    };
    this.service.addNews(val).subscribe(res =>{
      // alert(res.toString());
      console.log(res)
      alert("Thêm thành công!");
      this.showTT.refreshNewsList();
    });
  }


  update(){
    var val = {
      id:this.id,
      shortContent:this.shortContent,
      mainContent:this.mainContent,
      title:this.title,
      image:this.image,
      adminId:this.adminId,
    };
    // console.log(val)
    this.service.updateNews(val).subscribe(res =>{
      // alert(res.toString());
      alert("Đã cập nhật!");
      // this.showProd.closeClick();
      this.showTT.refreshNewsList();
    });
  }

}
