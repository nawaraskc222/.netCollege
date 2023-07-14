import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import { Student } from "./components/Student";
import { Home } from "./components/Home";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/counter',
    element: <Counter />
  },
  {
    path: '/fetch-data',
    element: <FetchData />
    },
    {
        path: '/student',
        element: <Student />
    }
];

export default AppRoutes;
