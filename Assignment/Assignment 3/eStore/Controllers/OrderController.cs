using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessObject;
using DataAccess.Repository;
using System.IO;
using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eStore.Controllers
{
    public class OrderController : Controller
    {
        IOrderRepository orderRepository = null;
        IMemberRepository memberRepository = new MemberRepository();
        IOrderDetailRepository orderDetailRepository = new OrderDetailRepository();

        public OrderController() => orderRepository = new OrderRepository();

        // GET: OrderController
        public ActionResult Index()
        {
            var orderList = orderRepository.GetOrders();
            return View(orderList);
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var order = orderRepository.GetOrder(id.Value);
            ViewBag.OrderDetails = orderDetailRepository.GetOrderDetailsByOrderId(id.Value);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {
            ViewBag.MemberId = new SelectList(memberRepository.GetMembers().Select(x => x.MemberId).ToList());
            return View();
        }

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Order order)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    orderRepository.InsertOrder(order);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(order);
            }
        }

        // GET: OrderController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.MemberId = new SelectList(memberRepository.GetMembers().Select(x => x.MemberId).ToList());
            var order = orderRepository.GetOrder(id.Value);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Order order)
        {
            try
            {
                if (id != order.OrderId)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    orderRepository.UpdateOrder(order);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(order);
            }
        }

        // GET: OrderController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var order = orderRepository.GetOrder(id.Value);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                orderRepository.DeleteOrder(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
