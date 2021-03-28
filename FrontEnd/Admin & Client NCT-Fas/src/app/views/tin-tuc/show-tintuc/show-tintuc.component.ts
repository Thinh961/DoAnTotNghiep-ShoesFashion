import { Component, OnInit } from '@angular/core';
import { SharedService } from "../../../_services/shared.service"

@Component({
  selector: 'app-show-tintuc',
  templateUrl: './show-tintuc.component.html',
})
export class ShowTintucComponent implements OnInit {

  constructor(private service:SharedService) { }

  NewsList:any=[];


  ModalTitle:string;
  ActivateAddEdit:boolean=false;
  news:any;

  ngOnInit() {
    this.refreshNewsList();
  }

  // Thêm sản phẩm
  addClick(){
    this.news={
      id:0,
      shortContent:"",
      mainContent:"",
      title:"",
      image:"",
      adminId:"",
    }
    this.ModalTitle="Thêm tin";
    this.ActivateAddEdit=true;
  }

  editClick(item){
    this.news=item;
    this.ModalTitle="Sửa tin";
    this.ActivateAddEdit=true;
  }

  deleteClick(item){
    if(confirm("Bạn có chắc chắn xóa?")){
      this.service.deleteNews(item.id).subscribe(data =>{
        alert("Xóa thành công!")
        this.refreshNewsList();
      })
    }
  }

  closeClick(){
    this.ActivateAddEdit=false;
    this.refreshNewsList();
  }

  // refresh dữ liệu trả về từ Products(ProductsList)
  refreshNewsList(){
    this.service.getNewsList().subscribe(data=>{
      this.NewsList=data;
      // this.DepartmentListWithoutFilter=data;
    });
  }

}
