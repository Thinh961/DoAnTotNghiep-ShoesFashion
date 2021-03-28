interface NavAttributes {
  [propName: string]: any;
}
interface NavWrapper {
  attributes: NavAttributes;
  element: string;
}
interface NavBadge {
  text: string;
  variant: string;
}
interface NavLabel {
  class?: string;
  variant: string;
}

export interface NavData {
  name?: string;
  url?: string;
  icon?: string;
  badge?: NavBadge;
  title?: boolean;
  children?: NavData[];
  variant?: string;
  attributes?: NavAttributes;
  divider?: boolean;
  class?: string;
  label?: NavLabel;
  wrapper?: NavWrapper;
}

export const navItems: NavData[] = [
  {
    name: "Dashboard",
    url: "dashboard",
    icon: "icon-speedometer",
    badge: {
      variant: "info",
      text: "NCT",
    },
  },

  {
    name: "---List <3---",
    url: "pages",
    icon: "icon-star",
    children: [
      {
        name: "Quản lý đơn hàng",
        url: "don-dat-hang",
        icon: "icon-star",
      },
      {
        name: "Quản lý danh mục",
        url: "danh-muc",
        icon: "icon-star",
      },
      {
        name: "Quản lý sản phẩm",
        url: "products",
        icon: "icon-star",
      },
      {
        name: "Quản lý khách hàng",
        url: "khach-hang",
        icon: "icon-star",
      },
      {
        name: "Nhà cung cấp",
        url: "nha-cung-cap",
        icon: "icon-star",
      },
      {
        name: "Quản lý tin tức",
        url: "tin-tuc",
        icon: "icon-star",
      },
      {
        name: "Khóa học",
        url: "khoa-hoc",
        icon: "icon-star",
      },
      {
        name: "Quản lý học viên",
        url: "students",
        icon: "icon-star",
      },
      {
        name: "Register",
        url: "register",
        icon: "icon-star",
      },
      // {
      //   name: "Error 404",
      //   url: "/404",
      //   icon: "icon-star",
      // },
      // {
      //   name: "Error 500",
      //   url: "/500",
      //   icon: "icon-star",
      // },
    ],
  },

];
