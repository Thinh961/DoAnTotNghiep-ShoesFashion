import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

// Import Containers
import { DefaultLayoutComponent } from './containers';

import { P404Component } from './views/error/404.component';
import { P500Component } from './views/error/500.component';
import { LoginComponent } from './views/login/login.component';
import { AuthGuard } from './_helpers/auth.guard';
import { ClientDefaultLayoutComponent } from './containers/client-default-layout/client-default-layout.component';


export const routes: Routes = [
  {
    path: '',
    redirectTo: 'client',
    pathMatch: 'full',
  },
  {
    path: '404',
    component: P404Component,
    data: {
      title: 'Page 404'
    }
  },
  {
    path: '500',
    component: P500Component,
    data: {
      title: 'Page 500'
    }
  },
  {
    path: 'login',
    component: LoginComponent,
    data: {
      title: 'Login Page'
    }
  },

  {
    path: '', component: ClientDefaultLayoutComponent,
    data: { title: 'Home' },
    children: [
      {
        path: 'client',
        loadChildren: './client/client.module#ClientModule',
      },
      // {
      //   path: 'home',
      //   loadChildren: './client/client.module#ClientModule',
      // },
    ]
  },

  {
    path: 'admin', component: DefaultLayoutComponent,
    data: { title: 'Home' },
    children: [
      {
        path: 'don-dat-hang',
        loadChildren: './views/don-dat-hang/don-dat-hang.module#DonDatHangModule', canActivate: [AuthGuard]
      },
      {
        path: 'danh-muc',
        loadChildren: './views/danh-muc/danh-muc.module#DanhMucModule', canActivate: [AuthGuard]
      },
      {
        path: 'products',
        loadChildren: './views/products/products.module#ProductsModule', canActivate: [AuthGuard]
      },
      {
        path: 'khach-hang',
        loadChildren: './views/khach-hang/khach-hang.module#KhachHangModule', canActivate: [AuthGuard]
      },
      {
        path: 'nha-cung-cap',
        loadChildren: './views/nha-cung-cap/nha-cung-cap.module#NhaCungCapModule', canActivate: [AuthGuard]
      },
      {
        path: 'tin-tuc',
        loadChildren: './views/tin-tuc/tin-tuc.module#TinTucModule', canActivate: [AuthGuard]
      },

      {
        path: 'khoa-hoc',
        loadChildren: './views/course/course.module#CourseModule', canActivate: [AuthGuard]
      },
      {
        path: 'dashboard',
        loadChildren: './views/dashboard/dashboard.module#DashboardModule', canActivate: [AuthGuard]
      },
      {
        path: 'students',
        loadChildren: './views/students/students.module#StudentsModule', canActivate: [AuthGuard]
      },
    ]
  },
  { path: '**', component: P404Component }
];

@NgModule({
  imports: [ RouterModule.forRoot(routes) ],
  exports: [ RouterModule ]
})
export class AppRoutingModule {}
