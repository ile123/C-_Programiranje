using Domain.Models;
using InvoiceAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly InvoiceRepository _invoiceRepository;
        public InvoiceController(InvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }
        [HttpGet]
        public IActionResult GetInvoices()
        {
            try
            {
                var invoices = _invoiceRepository.GetInvoices();
                return Ok(invoices);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("{invoiceId:int}")]
        public IActionResult GetInvoice(int invoiceId)
        {
            try
            {
                return Ok(_invoiceRepository.GetInvoice(invoiceId));
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPost]
        public IActionResult AddInvoice([FromBody] Invoice invoice)
        {
            if (invoice == null)
                return BadRequest();
            try
            {
                _invoiceRepository.InsertInvoice(invoice);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpPut]
        public IActionResult UpdateInvoice([FromBody] Invoice invoice)
        {
            if(invoice == null)
            {
                return BadRequest();
            }

            try
            {
                _invoiceRepository.UpdateInvoice(invoice);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpDelete("{invoiceId:int}")]
        public IActionResult DeleteInvoice(int invoiceId)
        {
            try
            {
                _invoiceRepository.DeleteInvoice(invoiceId);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}       
