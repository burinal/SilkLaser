using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;

namespace SilkLaser.Web.Classes.Utils
{
    /// <summary>
    /// ����������� �������� ������
    /// </summary>
    public static class RoutesManager
    {
        /// <summary>
        /// ������������ ��������� ���� � ���������� ����������� ��������
        /// </summary>
        /// <param name="name"></param>
        /// <param name="route">��������� ���� �����</param>
        /// <param name="routeMapping">�������</param>
        /// <param name="insertFirst">�������� �� ���� ����� ������ � ������� ������</param>
        public static void RegisterRoute(string name, string route, object routeMapping, bool insertFirst = false)
        {
            var newRoute = RouteTable.Routes.MapRoute(name, route, routeMapping);
            if (insertFirst)
            {
                RouteTable.Routes.Remove(newRoute);
                RouteTable.Routes.Insert(0,newRoute);
            }
        }

        /// <summary>
        /// ������� ��������� ���� �� ������� ������
        /// </summary>
        /// <param name="route">����</param>
        public static void RemoveRoute(string route)
        {
            /*var findedRoute = RouteTable.Routes.Cast<Route>().FirstOrDefault(r => r.Url.ToLower() == route.ToLower());
            if (findedRoute != null)
            {
                RouteTable.Routes.Remove(findedRoute);
            }*/
			// TODO: ��������
        }

        /// <summary>
        /// ��������� ��������� ���� �� ����� ��������
        /// </summary>
        /// <param name="oldRoute">������ ����</param>
        /// <param name="newRoute">����� ����</param>
        public static void UpdateRoute(string oldRoute, string newRoute)
        {
            /*var findedRoute = RouteTable.Routes.Cast<Route>().FirstOrDefault(r => r.Url.ToLower() == oldRoute.ToLower());
            if (findedRoute != null)
            {
                findedRoute.Url = newRoute;
            }*/
			// TODO ��������
        }
    }
}