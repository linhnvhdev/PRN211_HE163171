using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessObject;
using DataAccess.Repository;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace eStore.Controllers
{
    public class OrderDetailController : Controller
    {
        IOrderDetailRepository Repository = new OrderDetailRepository();
        IProductRepository productRepository = new ProductRepository();

        // GET: OrderDetailController
        public ActionResult Index(int? orderId)
        {
            if(orderId == null)
            {
                return NotFound();
            }
            var orderDetailList = Repository.GetOrderDetailsByOrderId(orderId.Value);
            if(orderDetailList == null)
            {
                return NotFound();
            }
            return View(orderDetailList);
        }

        // GET: OrderDetailController/Details/5
        public ActionResult Details(int? orderId,int? productId)
        {
            if (orderId == null || productId == null)
            {
                return NotFound();
            }
            var order = Repository.GetOrderDetail(orderId.Value,productId.Value);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // GET: OrderDetailController/Create
        public ActionResult Create(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            ViewBag.CurOrderId = id.Value;
            ViewBag.OrderId = new SelectList(Repository.GetOrdersDetails().Select(x => x.OrderId).ToList());
            ViewBag.ProductId = new SelectList(productRepository.GetProducts().Select(x => x.ProductId).ToList());
            return View();
        }

        // POST: OrderDetailController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderDetail orderDetail)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Repository.InsertOrderDetail(orderDetail);
                }
                return RedirectToAction("Details","Order",new {id=orderDetail.OrderId});
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(orderDetail);
            }
        }

        // GET: OrderDetailController/Edit/5
        public ActionResult Edit(int? orderId,int? productId)
        {
            if (orderId == null || productId == null)
            {
                return NotFound();
            }
            var orderDetail = Repository.GetOrderDetail(orderId.Value, productId.Value);
            if (orderDetail == null)
            {
                return NotFound();
            }
            return View(orderDetail);
        }

        // POST: OrderDetailController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int orderId, int productId, OrderDetail orderDetail)
        {
            try
            {
                if (orderId != orderDetail.OrderId || productId != orderDetail.ProductId)
                {
                    return NotFound();
                }
                if (ModelState.IsValid)
                {
                    Repository.UpdateOrderDetail(orderDetail);
                }
                return RedirectToAction("Details", "Order", new { id = orderDetail.OrderId });
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(orderDetail);
            }
        }

        // GET: OrderDetailController/Delete/5
        public ActionResult Delete(int? orderId,int? productId)
        {
            if (orderId == null || productId == null)
            {
                return NotFound();
            }
            var orderDetail = Repository.GetOrderDetail(orderId.Value, productId.Value);
            if (orderDetail == null)
            {
                return NotFound();
            }
            return View(orderDetail);
        }

        // POST: OrderDetailController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int orderId, int productId)
        {
            try
            {
                Repository.DeleteOrderDetail(orderId, productId);
                return RedirectToAction("Details", "Order", new { id = orderId });
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
